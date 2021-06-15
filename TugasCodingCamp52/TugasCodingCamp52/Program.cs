using System;
using System.Collections.Generic;

namespace TugasCodingCamp52
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CodingCamp> codingCamps = new List<CodingCamp>();
            CodingCamp codingCamp49 = new CodingCamp {Id = "MCC-REG-49-NET", Nama = "Coding Camp 49" };
            CodingCamp codingCamp48 = new CodingCamp {Id = "MCC-REG-48-NET", Nama = "Coding Camp 48" };
            CodingCamp codingCamp47 = new CodingCamp {Id = "MCC-REG-47-JAVA", Nama = "Coding Camp 47" };
            CodingCamp codingCamp46 = new CodingCamp {Id = "MCC-REG-46-NET", Nama = "Coding Camp 46" };

            codingCamps.Add(codingCamp49);
            codingCamps.Add(codingCamp48);
            codingCamps.Add(codingCamp47);
            codingCamps.Add(codingCamp46);

            Participant lingga = new Participant();
            lingga.Nik = "1021";
            lingga.Nama = "Lingga";
            lingga.CodingCamps = codingCamp48;
            
            Participant boni = new Participant();
            boni.Nik = "1022";
            boni.Nama = "Boni";
            boni.CodingCamps = codingCamp48;
            
            Participant morgan = new Participant();
            morgan.Nik = "1023";
            morgan.Nama = "Morgan";
            morgan.CodingCamps = codingCamp49;

            codingCamp48.Participants.Add(lingga);
            codingCamp48.Participants.Add(boni);
            codingCamp49.Participants.Add(morgan);

        A:

            Console.WriteLine("=========Menu=========");
            Console.WriteLine("1. Show Coding Camp");
            Console.WriteLine("2. Add Coding Camp");
            Console.WriteLine("3. Update Coding Camp");
            Console.WriteLine("4. Delete Coding Camp");
            Console.WriteLine("5. Add Participan");
            Console.WriteLine("======================");
            Console.Write("Pilih (1 - 5) : ");
            try
            {
                int menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        ShowCodingCamp(codingCamps);
                        goto A;

                    case 2:
                        AddCodingCamp(codingCamps);
                        goto A;

                    case 3:
                        UpdateCodingCamp(codingCamps);
                        goto A;

                    case 4:
                        DeleteCodingCamp(codingCamps);
                        goto A;

                    case 5:
                        AddParticipant(codingCamps);
                        goto A;
                    default:
                        Console.Clear();
                        Console.WriteLine("[Input invalid. Choose between 1 to 5]");
                        goto A;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("[Input invalid. Choose between 1 to 5]");
                goto A;
            }
        }

        //Show Coding Camp
        static void ShowCodingCamp(List<CodingCamp> codingCamps)
        {
            Console.Clear();
            Console.WriteLine("=====  List Coding Camp =====");
            foreach (var cc in codingCamps)
            {
                cc.ShowData();
            }

            Console.ReadKey();
            Console.Clear();
        }

        //Delete Coding Camp
        static void DeleteCodingCamp(List<CodingCamp> codingCamps)
        {
            int pilih;
            Console.Clear();
            CodingCamp cc = new CodingCamp();
            cc.ShowDataCC(codingCamps);
        D:
            try
            {
                Console.Write("Pilih Nomor Coding Camp  : ");
                pilih = Convert.ToInt32(Console.ReadLine());
                codingCamps.RemoveAt(pilih - 1);
                Console.WriteLine("Delete Succes!!!");
            }
            catch (Exception)
            {
                Console.WriteLine("[the input must match the coding camp number]");
                goto D;
            }

            Console.ReadKey();
            Console.Clear();
        }

        //Add Coding Camp
        static void AddCodingCamp(List<CodingCamp> codingCamps)
        {
            Console.WriteLine();
            Console.WriteLine("=======================");
            Console.Write("ID   : ");
            string id = Console.ReadLine();
            Console.Write("Nama : ");
            string nama = Console.ReadLine();

            codingCamps.Add(new CodingCamp { Id = id, Nama = nama });
            Console.WriteLine();

            Console.WriteLine("====Insert Succeses====");
            Console.ReadKey();
            Console.Clear();
        }

        //Update Coding Camp
        static void UpdateCodingCamp(List<CodingCamp> codingCamps)
        {
            Console.Clear();
            CodingCamp cc = new CodingCamp();
            cc.ShowDataCC(codingCamps);
            X:
            try
            {
                Console.Write("Pilih Nomor Coding Camp  : ");
                int pilih = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ID sebelum   : " + codingCamps[pilih - 1].Id);
                Console.WriteLine("Nama sebelum : " + codingCamps[pilih - 1].Nama);
                Console.WriteLine("==========================");
                Console.Write("ID   : ");
                codingCamps[pilih - 1].Id = Console.ReadLine();
                Console.Write("Nama : ");
                codingCamps[pilih - 1].Nama = Console.ReadLine();
                Console.WriteLine("Update Succes !!!");
            }
            catch (Exception)
            {
                Console.WriteLine("Nomor yang di input tidak sesuai");
                goto X;
            }
            Console.ReadKey();
            Console.Clear();
        }
        
        //Add Participant
        static void AddParticipant(List<CodingCamp> codingCamps)
        {
            string nik, nama;

            Console.Clear();
            CodingCamp cc = new CodingCamp();

            cc.ShowDataCC(codingCamps);
        X:
            try
            {
                Console.Write("Pilih Nomor Coding Camp  : ");
                int pilih = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(codingCamps[pilih - 1].Nama);
                Console.WriteLine("----------------------------");

                Console.Write("NIK  : ");
                nik = Console.ReadLine();

                Console.Write("Nama : ");
                nama = Console.ReadLine();

                Participant participant = new Participant();
                participant.Nik = nik;
                participant.Nama = nama;
                participant.CodingCamps = codingCamps[pilih - 1];
                codingCamps[pilih - 1].Participants.Add(participant);
                Console.WriteLine("Insert Participant Success!!!");
            }
            catch (Exception)
            {
                Console.WriteLine("Nomor yang di input tidak sesuai");
                goto X;
            }
            
            Console.ReadKey();
            Console.Clear();
        }

    }
}
