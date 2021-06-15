using System;
using System.Collections.Generic;
using System.Text;

namespace TugasCodingCamp52
{
    class CodingCamp
    {
        public string Id{ get; set; }
        public string Nama{ get; set; }
        public List<Participant> Participants { get; set; }

        public CodingCamp()
        {
            Participants = new List<Participant>();
        }

        public void ShowData()
        {
            Console.WriteLine("=============================");
            Console.WriteLine($"ID      : {Id}");
            Console.WriteLine($"Nama    : {Nama}");
            Console.WriteLine("Daftar Participan :");
            if (Participants.Count>0)
            {
                foreach (var p in Participants)
                {
                    Console.WriteLine(" ----------------------------");
                    Console.WriteLine($"    NIK     : {p.Nik}");
                    Console.WriteLine($"    Nama    : {p.Nama}");
                }
            }
            else
            {
                Console.WriteLine("     [Data Kosong]");
            }
            Console.WriteLine();
        }

        public void ShowDataCC(List<CodingCamp> codingCamps)
        {
            Console.WriteLine("=====  List Coding Camp =====");
            Console.WriteLine("=============================");
            for (int i = 0; i < codingCamps.Count; i++)
            {
                Console.WriteLine($"Nomor   : {i+1}");
                Console.WriteLine($"ID      : {codingCamps[i].Id}");
                Console.WriteLine($"Nama    : {codingCamps[i].Nama}");
                Console.WriteLine();
            }
        }

        public void ShowdataP(int j)
        {
            for (int i = 0; i < Participants.Count; i++)
            {
                Console.WriteLine($"Nomor       : {j + 1}");
                Console.WriteLine($"ID          : {Participants[i].Nik}");
                Console.WriteLine($"Nama        : {Participants[i].Nama}");
                Console.WriteLine($"Coding Camp : {Participants[i].CodingCamps.Nama}");
                Console.WriteLine();
                j++;
            }
        }
    }
}
