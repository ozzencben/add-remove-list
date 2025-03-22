using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_editing_app
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Merhabalar, liste düzenleme uygulamasına hoşgeldiniz.");

            Console.WriteLine("menu için herhangi bir tuşa basın");
            Console.ReadKey();


            string userChoose = string.Empty;

            ArrayList listValue = new ArrayList();

            do
            {
                Console.WriteLine("1. değer ekle");
                Console.WriteLine("2. değer listele");
                Console.WriteLine("3. değer ara");
                Console.WriteLine("4. değer düzenle");
                Console.WriteLine("5. değer sil");
                Console.WriteLine("6. uygulamadan çık");
                Console.Write("Yapmak istediğiniz işlemi seçin :");
                userChoose = Console.ReadLine();
                Console.Clear();

                switch (userChoose)
                {
                    case "1":

                        Console.Write("Eklemek istediğiniz değeri giriniz : ");
                        string userValue = Console.ReadLine();
                        listValue.Add(userValue);
                        Console.WriteLine("Değer başarılı bir şekilde eklendi.");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Dizi içerisindeki değerler : ");
                        for (int i = 0; i < listValue.Count; i++)
                        {
                            Console.WriteLine("{0}. değer : {1}", i, listValue[i]);
                        }
                        Console.ReadLine();
                        break;
                    case "3":

                        Console.Write("Aramak istediğiniz değeri girin : ");
                        string searchValue = Console.ReadLine();
                        if (listValue.IndexOf(searchValue) != -1)
                        {
                            Console.WriteLine("Aradığınız değer {0}. indekste", listValue.IndexOf(searchValue));
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız değer bulunamadı");
                        }
                        Console.ReadLine();
                        break;
                    case "4":

                        Console.WriteLine("Düzenlemek istediğiniz değerin index numarasını giriniz : ");
                        int indexValue = Convert.ToInt32(Console.ReadLine());
                        if (indexValue < listValue.Count)
                        {
                            Console.Write("Yeni değeri girin : ");
                            string newValue = Console.ReadLine();
                            listValue[indexValue] = newValue;
                            Console.WriteLine("Değer başarılı bir şekilde güncellenmiştir.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Girdiğiniz index dizi sınırlanırı aşıyor.");
                        }
                        break;
                    case "5":

                        Console.Write("Dizi içerisindeki tüm değerleri silmek istiyorsanız 'tümünü sil' yazın. Sadece index numarasına göre silme işlemi yapmak istiyorsanız 'index sil' yazın. ");
                        string userAnswer = Console.ReadLine();

                        if (userAnswer == "tümünü sil")
                        {
                            listValue.Clear();
                            Console.WriteLine("Dizi başarılı bir şekilde silindi.");
                        }
                        else if (userAnswer == "index sil")
                        {
                            Console.Write("Silmek istediğiniz değerin index numarasını girin :");
                            int deleteValue = Convert.ToInt32(Console.ReadLine());
                            if (deleteValue < listValue.Count)
                            {
                                listValue.RemoveAt(deleteValue);
                                Console.WriteLine("Seçtiğiniz index başarılı bir şekilde silindi.");
                            }
                            else
                            {
                                Console.WriteLine("Girdiğiniz index numarası dizi sınırları içerisinnde bulunmuyor.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem adı girin.");
                        }

                        break;
                }

            }
            while (userChoose != "6");

            Console.WriteLine("Uygulamadan başarılı bir şekilde çıkıldı.");
            Console.ReadLine();

        }
    }
}
