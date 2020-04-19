using System;

public static class kel26
{
	static int transaksi(int[] jumlah, int b)
	{
		int hasil = 0;

		for (int a = 0; a < b; a++)
		{
			hasil = jumlah[a] + hasil;
		}
		return hasil;
	}

	static void Main(string[] args)
	{
		int[] jumlah = new int[5];
		int[] harga = { 500000, 700000, 800000 };
		int[] count = new int[5];
		int[] pin = new int[5];
		int a;
		int b;
		int c;
		int pilihan;
		int bayar;
		char lanjut;

		b = 0;
		Console.WriteLine("======================  Selamat Datang di Toko Sepatu Aegis  ======================\n");
		Console.WriteLine("Silahkan Pilih Sepatu yang Ingin Dibeli");
		Console.Write("1. Puma");
		Console.Write("\n");
		Console.Write("2. Adidas");
		Console.Write("\n");
		Console.Write("3. Nike");
		Console.Write("\n");

		for (a = 0; a < 5; a++)
		{
			Console.Write("Masukkan Pilihan : ");
			pilihan = Convert.ToInt32(Console.ReadLine());
			switch (pilihan)
			{
				case 1:
					Console.Write("Masukkan Jumlah Sepatu yang Ingin Dibeli : ");
					c = Convert.ToInt32(Console.ReadLine());
					count[a] = c;
					jumlah[a] = c * harga[a];
					pin[a] = 1;
					break;

				case 2:
					Console.Write("Masukkan Jumlah Sepatu yang Ingin Dibeli : ");
					c = Convert.ToInt32(Console.ReadLine());
					count[a] = c;
					jumlah[a] = c * harga[a];
					pin[a] = 2;
					break;

				case 3:
					Console.Write("Masukkan Jumlah Sepatu yang Ingin Dibeli : ");
					c = Convert.ToInt32(Console.ReadLine());
					count[a] = c;
					jumlah[a] = c * harga[a];
					pin[a] = 1;
					break;

				default:
					Console.Write("Inputan Anda Salah");
					break;
			}
			b = b + 1;
			Console.Write("\n");
			Console.Write("Ingin Menambah Transaksi [y/t] ? ");
			lanjut = Convert.ToChar(Console.ReadLine());
			Console.Write("\n");

			if (lanjut == 't')
			{
				break;
			}
		}
		for (a = 0; a < b; a++)
		{
			Console.Write("Nama Barang : ");

			if (pin[a] == 1)
			{
				Console.Write("Puma");
			}
			else if (pin[a] == 2)
			{
				Console.Write("Adidas");
			}
			else
			{
				Console.Write("Nike");
			}

			Console.Write("\nJumlah : ");
			Console.WriteLine(count[a]);
			Console.Write("Harga : ");
			Console.WriteLine(harga[a]);
			Console.Write("Total : ");
			Console.WriteLine(jumlah[a]);
			Console.Write("\n");
		}

		int total = transaksi(jumlah, b);
		Console.Write("Anda Belanja Sebesar Rp.");
		Console.Write(total);
		Console.Write("\n");

		Console.Write("Anda Bayar : ");
		bayar = Convert.ToInt32(Console.ReadLine());

		if (bayar < total)
		{
			Console.Write("Uang Anda Kurang");
		}
		else
		{
			Console.Write("Uang Kembalian Anda Sebesar Rp.");
			Console.Write(bayar - total);
			Console.Write("\n");
			Console.Write("\n");
			Console.Write("===================  Terima Kasih Telah Berbelanja di Toko Kami  ===================");
		}
		Console.ReadKey();
	}

}