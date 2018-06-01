using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QuiApp.Models
{
    public partial class QuiAppDbContext : DbContext
    {
        public virtual DbSet<Answers> Answers { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<ClassStudents> ClassStudents { get; set; }
        public virtual DbSet<ClassTutors> ClassTutors { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<CourseStudents> CourseStudents { get; set; }
        public virtual DbSet<CourseTutors> CourseTutors { get; set; }
        public virtual DbSet<PartAttempts> PartAttempts { get; set; }
        public virtual DbSet<PartQuestions> PartQuestions { get; set; }
        public virtual DbSet<Parts> Parts { get; set; }
        public virtual DbSet<QuestionAttempts> QuestionAttempts { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<Staffs> Staffs { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<StudentTests> StudentTests { get; set; }
        public virtual DbSet<TestAttempts> TestAttempts { get; set; }
        public virtual DbSet<Tests> Tests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=QuiAppDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answers>(entity =>
            {
                entity.Property(e => e.AnswerOption).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Answer_Question");
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Classes>(entity =>
            {
                entity.Property(e => e.ClassTitle).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Class_Course");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Class_Staff");
            });

            modelBuilder.Entity<ClassStudents>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.JointDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassStudents)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassStudent_Class");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ClassStudents)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassStudent_Student");
            });

            modelBuilder.Entity<ClassTutors>(entity =>
            {
                entity.Property(e => e.AssignedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassTutors)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassTutor_Class");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.ClassTutors)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassTutor_Staff");
            });

            modelBuilder.Entity<Courses>(entity =>
            {
                entity.Property(e => e.CourseCode).HasMaxLength(20);

                entity.Property(e => e.CourseTitle).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LongDescription).HasMaxLength(4000);

                entity.Property(e => e.ShortDescription).HasMaxLength(200);

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Course_Staff");
            });

            modelBuilder.Entity<CourseStudents>(entity =>
            {
                entity.Property(e => e.EnroledDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseStudents)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseStudent_Course");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.CourseStudents)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseStudent_Student");
            });

            modelBuilder.Entity<CourseTutors>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.NominatedDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseTutors)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseTutor_Course");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.CourseTutors)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseTutor_Staff");
            });

            modelBuilder.Entity<PartAttempts>(entity =>
            {
                entity.HasOne(d => d.Part)
                    .WithMany(p => p.PartAttempts)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartAttempt_Part");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.PartAttempts)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartAttempt_Student");

                entity.HasOne(d => d.TestAttempt)
                    .WithMany(p => p.PartAttempts)
                    .HasForeignKey(d => d.TestAttemptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartAttempt_TestAttempt");
            });

            modelBuilder.Entity<PartQuestions>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.PartQuestions)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartQuestion_Part");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.PartQuestions)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartQuestion_Question");
            });

            modelBuilder.Entity<Parts>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.PartDescription).HasMaxLength(200);

                entity.Property(e => e.PartOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartTitle).HasMaxLength(50);

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.Parts)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Part_Test");
            });

            modelBuilder.Entity<QuestionAttempts>(entity =>
            {
                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionAttempts)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionAttempt_Question");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.QuestionAttempts)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionAttempt_Student");

                entity.HasOne(d => d.TestAttempt)
                    .WithMany(p => p.QuestionAttempts)
                    .HasForeignKey(d => d.TestAttemptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionAttempt_TestAttempt");
            });

            modelBuilder.Entity<Questions>(entity =>
            {
                entity.Property(e => e.Content).HasMaxLength(4000);

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsRepeatable).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.VideoEmbed).HasMaxLength(100);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Question_course");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Question_User");
            });

            modelBuilder.Entity<Staffs>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Office).HasMaxLength(150);

                entity.Property(e => e.Title).HasMaxLength(10);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Staffs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Staff_User");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_User");
            });

            modelBuilder.Entity<StudentTests>(entity =>
            {
                entity.Property(e => e.EdittedBy).HasMaxLength(100);

                entity.Property(e => e.EdittedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MarkedOn).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentTests)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentTest_Student");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.StudentTests)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentTest_Test");
            });

            modelBuilder.Entity<TestAttempts>(entity =>
            {
                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TestAttempts)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestAttempt_Student");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.TestAttempts)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestAttempt_Test");
            });

            modelBuilder.Entity<Tests>(entity =>
            {
                entity.Property(e => e.AllowedAttempts).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Tests)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Test_Class");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Tests)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Test_Course");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Tests)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Test_Staff");
            });
        }
    }
}
