namespace com.educacionit.ms.pet.dataaccess
{
    using com.educacionit.ms.pet.dataaccess.Mapping;
    using com.educacionit.ms.pet.domain.model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PetsDbContext : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'PetsDbContext' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'com.educacionit.ms.pet.dataaccess.PetsDbContext' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'PetsDbContext'  en el archivo de configuración de la aplicación.
        public PetsDbContext()
            : base("name=PetsDbContext")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Adopter> Adopters { get; set; }
        public virtual DbSet<Adoption> Adoptions { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Person> Peoples { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<PetType> PetTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressMap ());
            modelBuilder.Configurations.Add(new AdopterMap());
            modelBuilder.Configurations.Add(new AdoptionMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new OwnerMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new PetMap());

        }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}