namespace iti_project.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateDepartmentsData : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[Departments] ( [Name], [Description]) VALUES ( N'Machine Learning', N'Machine learning is an application of artificial intelligence (AI) that provides systems the ability to automatically learn and improve from experience without being explicitly programmed. Machine learning focuses on the development of computer programs that can access data and use it learn for themselves.')
                INSERT INTO [dbo].[Departments] ( [Name], [Description]) VALUES ( N'Web Development', N'Web development is the work involved in developing a Web site for the Internet or an intranet. Web development can range from developing a simple single static page of plain text to complex Web-based Internet applications, electronic businesses, and social network services.')
                INSERT INTO [dbo].[Departments] ( [Name], [Description]) VALUES ( N'Computer Networks', N'A computer network is a group of computers that use a set of common communication protocols over digital interconnections for the purpose of sharing resources located on or provided by the network nodes.')
                INSERT INTO [dbo].[Departments] ( [Name], [Description]) VALUES ( N'Mobile Apps', N'A mobile app developer uses programming languages and development skills to create, test, and develop applications on mobile devices. They work in popular operating system environments like iOS and Android and often take into account UI and UX principles when creating applications.')



INSERT INTO [dbo].[Courses] ( [Name], [Description], [DepartmentId]) VALUES ( N'CSS3 For Beginners', N'This course was designed for students starting out in Front End Web Development wanting to learn CSS3 to get started.!', 2)
INSERT INTO [dbo].[Courses] ( [Name], [Description], [DepartmentId]) VALUES ( N'JavaScript For Beginners', N'This course was designed for students starting out in Front End Web Development wanting to learn JavaScript to get started.', 2)
INSERT INTO [dbo].[Courses] ( [Name], [Description], [DepartmentId]) VALUES ( N'HTML5 For Beginners', N'This course was designed for students starting out in Front End Web Development wanting to learn HTML5 to get started.', 2)
INSERT INTO [dbo].[Courses] ( [Name], [Description], [DepartmentId]) VALUES ( N'Introduction to Java Programming', N'you gain extensive hands-on experience writing, compiling, and executing Java programs. You will learn to build robust applications that use Java’s object-oriented features. ', 4)
INSERT INTO [dbo].[Courses] ( [Name], [Description], [DepartmentId]) VALUES ( N'Android Developer Fundamentals', N'In the Android Developer Fundamentals course, you learn basic Android programming concepts and build a variety of apps, using the Java programming language. You start with Hello World and work your way up to apps that schedule jobs, update settings, and use Android Architecture Components.', 4)
INSERT INTO [dbo].[Courses] ( [Name], [Description], [DepartmentId]) VALUES ( N'Build Native Mobile Apps with Flutter', N'In this course, you''ll learn how to use Flutter to quickly develop high-quality, interactive mobile applications for iOS and Android devices. ', 4)
INSERT INTO [dbo].[Courses] ( [Name], [Description], [DepartmentId]) VALUES ( N'CCNA', N'The CCNA certification validates your skills and knowledge in network fundamentals, network access, IP connectivity, IP services, security fundamentals, and automation and programmability.', 3)

                ");


        }

        public override void Down()
        {
        }
    }
}
