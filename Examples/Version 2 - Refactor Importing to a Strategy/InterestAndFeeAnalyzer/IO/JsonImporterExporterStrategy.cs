using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace InterestAndFeeAnalyzer.IO
{
    public class JsonImporterExporterStrategy : ImportExporterStrategy
    {

        public override List<BankAccount> Load(string filename)
        {
            List<BankAccount> accounts = null;
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<BankAccount>), new Type[] { typeof(BankAccount), typeof(CheckingAccount), typeof(SavingsAccount) });

            if (OpenReader(filename))
            {
                accounts = serializer.ReadObject(Reader.BaseStream) as List<BankAccount>;
                Reader.Close();
            }

            return accounts;
        }

        public override void Save(string filename, List<BankAccount> accounts)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<BankAccount>), new Type[] { typeof(BankAccount), typeof(CheckingAccount), typeof(SavingsAccount) });

            if (OpenWriter(filename))
            {
                serializer.WriteObject(Writer.BaseStream, accounts);
                Writer.Close();
            }
        }
    }
}
