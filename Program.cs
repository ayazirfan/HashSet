internal class Program
{
    private static void Main(string[] args)
    {
        var sesliHarf = new HashSet<char>()
        {
        'e','ı','i','u','ü','o','ö','b'
        };
                
        KoleksiyonYazdir(sesliHarf);
        sesliHarf.Add('a');

        KoleksiyonYazdir(sesliHarf);

        sesliHarf.Remove('b');
        KoleksiyonYazdir(sesliHarf);
        var alfabe = new List<char>();
        for (int i = 97; i < 123; i++)
        {
            alfabe.Add((char)i);
        }
        // alfabe.ForEach(k=> Console.Write($"{k,3}"));
        KoleksiyonYazdir(alfabe);

        // Türkçe'de kullanılan sesli harfler
        // sesliHarf.ExceptWith(alfabe);
        sesliHarf.UnionWith(alfabe);
        KoleksiyonYazdir(sesliHarf);


    }    

        static void KoleksiyonYazdir(IEnumerable<char> koleksiyon)
    {    Console.WriteLine();
    int i = 0;
        foreach (char k in koleksiyon)
        {
            Console.Write($"{k,5}");
            i++;
        }
        System.Console.WriteLine("\nEleman sayısı: {0}", i);
        Console.WriteLine();
        // Console.WriteLine("\nEleman sayısı: {0}", koleksiyon.Count);
    }
}