namespace FitUp.ExercisesService.DataModel.Migrations
{
    using FitUp.ExercisesService.DataModel.Data;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;

    [DbContext(typeof(ExercisesServiceDbContext))]
    partial class ExercisesServiceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            #pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FitUp.ExercisesService.DataModel.Models.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Equipments", (string)null);
                });

            modelBuilder.Entity("FitUp.ExercisesService.DataModel.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.Property<int>("DifficultLevel")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<byte[]>("Video")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Exercises", (string)null);
                });

            modelBuilder.Entity("FitUp.ExercisesService.DataModel.Models.ExerciseEquipment", b =>
                {
                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("ExerciseId", "EquipmentId");

                    b.HasIndex("EquipmentId");

                    b.ToTable("ExerciseEquipments", (string)null);
                });

            modelBuilder.Entity("FitUp.ExercisesService.DataModel.Models.ExerciseMuscleGroup", b =>
                {
                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("MuscleGroupId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("ExerciseId", "MuscleGroupId");

                    b.HasIndex("MuscleGroupId");

                    b.ToTable("ExerciseMuscleGroups", (string)null);
                });

            modelBuilder.Entity("FitUp.ExercisesService.DataModel.Models.MuscleGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("MuscleGroups", (string)null);
                });

            modelBuilder.Entity("FitUp.ExercisesService.DataModel.Models.ExerciseEquipment", b =>
                {
                    b.HasOne("FitUp.ExercisesService.DataModel.Models.Equipment", "Equipment")
                        .WithMany("ExerciseEquipments")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FitUp.ExercisesService.DataModel.Models.Exercise", "Exercise")
                        .WithMany("ExerciseEquipments")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Equipment");

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("FitUp.ExercisesService.DataModel.Models.ExerciseMuscleGroup", b =>
                {
                    b.HasOne("FitUp.ExercisesService.DataModel.Models.Exercise", "Exercise")
                        .WithMany("ExerciseMuscleGroups")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FitUp.ExercisesService.DataModel.Models.MuscleGroup", "MuscleGroup")
                        .WithMany("ExerciseMuscleGroups")
                        .HasForeignKey("MuscleGroupId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("MuscleGroup");
                });

            modelBuilder.Entity("FitUp.ExercisesService.DataModel.Models.Equipment", b =>
                {
                    b.Navigation("ExerciseEquipments");
                });

            modelBuilder.Entity("FitUp.ExercisesService.DataModel.Models.Exercise", b =>
                {
                    b.Navigation("ExerciseEquipments");

                    b.Navigation("ExerciseMuscleGroups");
                });

            modelBuilder.Entity("FitUp.ExercisesService.DataModel.Models.MuscleGroup", b =>
                {
                    b.Navigation("ExerciseMuscleGroups");
                });
#pragma warning restore 612, 618
        }
    }
}
