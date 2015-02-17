﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPLConqueror_Core
{
    public class InfoLogger : Logger
    {

        public InfoLogger(String location)
            : base(location)
        {
            Console.SetOut(writer);
        }

        /// <summary>
        /// Logs general information depending on what log mechanism was chosen (console, file, gui). Todo: currently only logging at file
        /// </summary>
        /// <param name="msg">The message to be printed or logged</param>
        public override void log(String msg)
        {
            if (writer != null)
                writer.Write(msg);
            else
                Console.Write(msg);
        }

    }
}