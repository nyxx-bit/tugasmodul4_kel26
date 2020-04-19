using System;

public static class kel26
{
	public static int transaksi(int[] jumlah, int b)
	{
		int hasil = 0;

		for (int a = 0; a < b; a++)
		{
			hasil = jumlah[a] + hasil;
		}
		return hasil;
	}

	static int Main()
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

		Console.Write("tekan 1. untuk membeli puma");
		Console.Write("\n");
		Console.Write("tekan 2. untuk membeli adidas");
		Console.Write("\n");
		Console.Write("tekan 3. untuk membeli nike");
		Console.Write("\n");

		for (a = 0; a < 5; a++)
		{
			Console.Write("masukkan pilihan ");
			pilihan = Convert.ToInt32(Console.ReadLine());
			switch (pilihan)
			{
				case 1:
					Console.Write("masukkan jumlah sepatu puma yang dibeli ");
					c = Convert.ToInt32(Console.ReadLine());
					count[a] = c;
					jumlah[a] = c * harga[a];
					pin[a] = 1;
					break;

				case 2:
					Console.Write("masukkan jumlah sepatu adidas yang dibeli ");
					c = Convert.ToInt32(Console.ReadLine());
					count[a] = c;
					jumlah[a] = c * harga[a];
					pin[a] = 2;
					break;

				case 3:
					Console.Write("masukkan jumlah sepatu adidas yang dibeli ");
					c = Convert.ToInt32(Console.ReadLine());
					count[a] = c;
					jumlah[a] = c * harga[a];
					pin[a] = 1;
					break;

				default:
					Console.Write("inputan anda salah");
					break;
			}
			b = b + 1;
			Console.Write("\n");
			Console.Write("ingin menambah transaksi [y/t]");
			lanjut = Char.TryParse(0;
			Console.Write("\n");

			if (lanjut == 't')
			{
				break;
			}
		}
		for (a = 0; a < b; a++)
		{
			Console.Write("nama barang : ");

			if (pin[a] == 1)
			{
				Console.Write("puma");
			}
			else if (pin[a] == 2)
			{
				Console.Write("adidas");
			}
			else
			{
				Console.Write("nike");
			}

			Console.Write(" jumlah : ");
			Console.Write(count[a]);
			Console.Write(" harga : ");
			Console.Write(harga[a]);
			Console.Write(" total : ");
			Console.Write(jumlah[a]);
			Console.Write(" ");
			Console.Write("\n");
		}

		int total = transaksi(jumlah, b);
		Console.Write("anda belanja sebesar Rp. ");
		Console.Write(total);
		Console.Write(" rupiah");
		Console.Write("\n");

		Console.Write("anda bayar ");
		bayar = Convert.ToInt32(Console.ReadLine());

		if (bayar < total)
		{
			Console.Write("uang anda kurang");
		}
		else
		{
			Console.Write("uang kembalian anda sebesar Rp. ");
			Console.Write(bayar - total);
			Console.Write(" rupiah");
			Console.Write("\n");
			Console.Write("\n");
			Console.Write("======================  trimakasih telah belanja di toko kami  ==================================");
		}
		Console.ReadKey(true);
	}

}