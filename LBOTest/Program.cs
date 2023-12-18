using System;
using LBOTest;

Context c = new Context("Server=localhost;Trusted_Connection=True;TrustServerCertificate=True;Database=test;");

var att = await c.AttachmentData.FindAsync(2);

Console.WriteLine("Hello, World!");