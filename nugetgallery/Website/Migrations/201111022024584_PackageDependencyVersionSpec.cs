namespace NuGetGallery.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PackageDependencyVersionSpec : DbMigration
    {
        public override void Up()
        {
            AlterColumn("PackageDependencies", "VersionRange", col => col.String(nullable: true));
            RenameColumn("PackageDependencies", "VersionRange", "VersionSpec");
        }

        public override void Down()
        {
            RenameColumn("PackageDependencies", "VersionSpec", "VersionRange");
        }
    }
}
