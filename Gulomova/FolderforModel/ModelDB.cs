namespace Gulomova.FolderforModel
{
    using System.Data.Entity;

    // Класс контекста: соответствует выбранной части БД MotorbikeDB
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        // Коллекция объектов таблицы Table_Motorbike
        public virtual DbSet<Table_Motorbike> Table_Motorbike { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
