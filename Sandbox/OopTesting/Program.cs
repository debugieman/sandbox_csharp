var names = new List<string> { "name", "Anna", "Basia", "Filip" };

// dodawanie do listy 
names.Add("Maria");
names.Add("Marek");
names.Add("Patryk");
names.Add("Anielka");
names.Add("Ania");
// foreach string
foreach (string name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}");
}

// wyciąganie z listy
var index = names.IndexOf("Basia");
Console.WriteLine(index);


// Wyszukiwanie w liscie  (daje [-1] kiedy nie ma w liście czego szukamy )
Console.WriteLine(names[0]);

// Sorotwanie string metodą name.Sort(); na zasadzie A<B<C<D
/*names.Sort();
foreach ( name in names)
{
    Console.WriteLine($"Hello {names.ToUpper)  !");
 }
/*