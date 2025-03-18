using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Notebook : Product
    {
        private byte Ram;
        public int Storage;
        public byte RAM
        {
            get
            { 
                return Ram;
            }
            private set
            {
                if (value > 0)
                {
                    Ram = value;
                }

                else
                {
                    
                    Console.WriteLine("RAM sıfırdan büyük olmalıdır");
                }
            }
        }
        public Notebook (string name, string description, int count, double price, byte ram, int storage): base(name, description, count, price)
        {
            this.Ram=ram;
            this.Storage=storage;


        }
        public string GetFullInfo()
        {
            return $"Notebook: {Name}, Açıklama: {Description}, Stok: {Count}, Fiyat: {Price}$, RAM: {RAM}GB, Depolama: {Storage}GB";
        }
        public void ShowFullData()
        {
            Console.WriteLine(GetFullInfo());
        }

    }
}
