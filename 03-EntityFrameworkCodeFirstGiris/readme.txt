Entity Framework Code First

*Bir ORM(Object Relational Mapping) aracıdır.
*Senin oluşturduğun modele uygun olarak veritabının oluşturur ve yönetir.
*Oluturduğun veri sınıfları (entity class) toblolarla eşleştirilir.
*DbContext sınıfı ise veritabanına karşılık gelir


ADIM1 : Install-Package EntityFramework

ADIM2 : Model sınıfını oluştur.
Kisi > *Id *Ad

ADIM3 : Conteşt sınıfını DbContext'ten mirasla oluştur.

KisiContext : DbContext
* Kisiler - DbSet<Kisi>

Artık kullanıma hazır (bu anlatım en minimal adımlarla) 

KULLANIM: 
using (var db = new KisiContext())
{
	db.Kisiler.Add(new Kisi() {Ad = "Ali"});
	db.Kisiler.Add(new Kisi() {Ad = "Can"});
	db.SaveChanges();

	foreach (Kisi k in db.Kisiler)
	{
		Console.Writeline(k.Id + " " k.Ad);
	}
}