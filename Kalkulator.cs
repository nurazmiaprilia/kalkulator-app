using System;

	class Kalkulator
	{
		static void Main(string[] args)
		{
			Console.Title = "Aplikasi Kalkulator";
			
             float Tambah, a, b;
             float Kurang, c, d;
             float Kali, e, f;
             float Bagi, g, h;
             int Pilih;

             Console.WriteLine("*PROGRAM KALKULATOR SEDERHANA*");
             Console.WriteLine("=====Pilih Menu Kalkulator=====");
             Console.WriteLine("1. Penambahan");
             Console.WriteLine("2. Pengurangan");
             Console.WriteLine("3. Perkalian");
             Console.WriteLine("4. Pembagian");
             Console.WriteLine("===============================");
             Console.Write("Input nomor menu [1/2/3/4]: ");
             Pilih = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine();
             
             switch (Pilih)
             {
                 case 1:
                 Console.Write("Inputkan nilai a = ");
                 a = Convert.ToSingle(Console.ReadLine());
                 Console.Write("Inputkan nilai b = ");
                 b = Convert.ToSingle(Console.ReadLine());
                 Tambah = a + b;
				 Console.WriteLine();
                 Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Tambah);
                 break;
                 
                 case 2:
                 Console.Write("Inputkan nilai a = ");
                 c = Convert.ToSingle(Console.ReadLine());
                 Console.Write("Inputkan nilai b = ");
                 d = Convert.ToSingle(Console.ReadLine());
                 Kurang = c - d;
				 Console.WriteLine();
                 Console.WriteLine("Hasil Pengurangan " + c + " - " + d + " = " + Kurang);
                 break;
                 
                 case 3:
                 Console.Write("Inputkan nilai a = ");
                 e = Convert.ToSingle(Console.ReadLine());
                 Console.Write("Inputkan nilai b = ");
                 f = Convert.ToSingle(Console.ReadLine());
                 Kali = e * f;
				 Console.WriteLine();
                 Console.WriteLine("Hasil Perkalian " + e + " * " + f + " = " + Kali);
                 break;
                 
                 case 4:
                 Console.Write("Inputkan nilai a = ");
                 g = Convert.ToSingle(Console.ReadLine());
                 Console.Write("Inputkan nilai b = ");
                 h = Convert.ToSingle(Console.ReadLine());
                 Bagi = g / h;
				 Console.WriteLine();
                 Console.WriteLine("Hasil Pembagian " + g + " / " + h + " = " + Bagi);
                 break;
                 
                 default :
                 Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia");
                 break;
             }
            
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
            
		}
	}