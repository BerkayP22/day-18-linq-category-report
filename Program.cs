var products = new List<Product>
{
    new("Kalem", "Kırtasiye", 12),
    new("Defter", "Kırtasiye", 5),
    new("Kupa", "Ev", 8)
};

foreach (var group in products.GroupBy(p => p.Category))
    Console.WriteLine($"{group.Key}: {group.Count()} ürün, {group.Sum(p => p.Stock)} stok");

Console.WriteLine($"Stokta ürün var mı? {products.Any(p => p.Stock > 0)}");
Console.WriteLine($"Hepsi stokta mı? {products.All(p => p.Stock > 0)}");
Console.WriteLine($"İlk kırtasiye ürünü: {products.FirstOrDefault(p => p.Category == "Kırtasiye")?.Name ?? "Yok"}");

record Product(string Name, string Category, int Stock);
