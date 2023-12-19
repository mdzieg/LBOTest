using System;
using LBOTest;
using LBOTest.Model;


var id = CreateData();

//this works
LoadData(id);

//this hangs
await LoadDataAsync(id);

Console.WriteLine("Hello, World!");

int CreateData()
{
    Context c = new Context("Server=localhost;Trusted_Connection=True;TrustServerCertificate=True;Database=test;");
    var all = c.AttachmentData.ToList();
    c.AttachmentData.RemoveRange(all);
    c.SaveChanges();

    var a = new AttachmentData()
    {
        Data = File.ReadAllBytes("data.bin")
    };
    
    c.AttachmentData.Add(a);
    c.SaveChanges();

    return a.Id;
}

void LoadData(int i)
{
    Context c = new Context("Server=localhost;Trusted_Connection=True;TrustServerCertificate=True;Database=test;");
    var att = c.AttachmentData.Find(i);
}

async Task LoadDataAsync(int i)
{
    Context c = new Context("Server=localhost;Trusted_Connection=True;TrustServerCertificate=True;Database=test;");
    var att = await c.AttachmentData.FindAsync(i);
}