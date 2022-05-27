using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flightcontroller_Client
{
    public class FlightControllerParser
    {
        public enum ParseResult
        {
            parsing = 0,
            done = 1
        }

        public enum ParserState
        {
            sync,
            messageID,
            frameCounter,
            reserved,
            size,
            payload
        }

        private ParserState state = ParserState.sync;
        private int subStateCounter = 0;
        private byte[] msg = new byte[1024];
        private int bytesLeft = 0;
        private int byteCounter = 0;

        private void Reset()
        {
            state = ParserState.sync;
            subStateCounter = 0;
            bytesLeft = 0;
            byteCounter = 0;
        }

        public byte[] GetMessage()
        {
            byte[] msgCpy = new byte[msg.Length];
            Array.Copy(msg, msgCpy, msg.Length);

            Reset();

            return msgCpy;
        }

        public ParseResult Parse(byte rxByte)
        {
            switch (state)
            {
                case ParserState.sync:
                    
                    if (rxByte == 0x7e)
                    {
                        msg[byteCounter++] = rxByte;
                        state = ParserState.messageID;
                    }

                    break;

                case ParserState.messageID:
                    msg[byteCounter++] = rxByte;
                    state = ParserState.frameCounter;

                    break;

                case ParserState.frameCounter:
                    msg[byteCounter++] = rxByte;
                    state = ParserState.reserved;

                    break;

                case ParserState.reserved:
                    msg[byteCounter++] = rxByte;
                    state = ParserState.size;

                    break;

                case ParserState.size:
                    msg[byteCounter++] = rxByte;

                    if (subStateCounter++ == 1)
                    {
                        state = ParserState.payload;
                        subStateCounter = 0;
                        bytesLeft = BitConverter.ToInt16(msg, 4);
                        Array.Resize(ref msg, bytesLeft);
                        bytesLeft -= 6;
                    }
                    break;

                case ParserState.payload:

                    bytesLeft--;
                    msg[byteCounter++] = rxByte;

                    if (bytesLeft > 0)
                    {
                        return ParseResult.parsing;
                    }
                    else
                    {
                        return ParseResult.done;
                    }
            }

            return ParseResult.parsing;
        }
    }
}
