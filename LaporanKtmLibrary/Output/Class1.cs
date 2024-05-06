using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaporanKtmLibrary.Output
{
    internal class GeneralMenu
    {

        public String startPage()
        {
            string x;
            Console.WriteLine("===== Layanan Pengaduan Kehilangan KTM =====");
            Console.WriteLine(" ");
            Console.WriteLine(" 1. Create Laporan Baru");
            Console.WriteLine(" 2. Lihat Laporan Aktif");
            Console.WriteLine(" 3. Ubah Laporan Aktif");
            Console.WriteLine(" 4. Exit");
            Console.WriteLine(" ");
            Console.WriteLine("Masukan: ");
            return x = Console.ReadLine();

        }

        public String createPage()
        {
            Console.WriteLine("===== Create Laporan Baru =====");
            Console.WriteLine(" ");
        }

        public String lihatPage()
        {
            Console.WriteLine("===== Show Laporan Baru =====");
        }

        public String editPage()
        {
            Console.WriteLine("===== Edit Laporan Baru =====");
        }

        public String endPage()
        {
            Console.WriteLine("======== Terima Kasih Sudah Melapor! ========");
        }
    }
}
