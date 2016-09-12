﻿using System.Collections.Generic;
using System.IO;
using System;

namespace InterestAndFeeAnalyzer.IO
{
    public abstract class ImportExporterStrategy
    {
        protected StreamReader Reader { get; set; }

        protected StreamWriter Writer { get; set; }
        public abstract List<BankAccount> Load(string filename);
        public abstract void Save(string filename, List<BankAccount> acccounts);

        protected virtual bool OpenReader(string filename)
        {
            bool result = false;
            try
            {
                Reader = new StreamReader(filename);
                result = true;
            }
            catch (Exception err)
            {
                Console.WriteLine($"Cannot open input file {filename}, error={err}");
            }

            return result;
        }


        protected virtual bool OpenWriter(string filename)
        {
            bool result = false;
            try
            {
                Writer = new StreamWriter(filename);
                result = true;
            }
            catch (Exception err)
            {
                Console.WriteLine($"Cannot open output file {filename}, error={err}");
            }

            return result;
        }
    }
}
