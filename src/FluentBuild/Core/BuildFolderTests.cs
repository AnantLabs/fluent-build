using FluentBuild.Core;
using FluentBuild.FilesAndDirectories.FileSet;
using NUnit.Framework;

using Rhino.Mocks;

namespace FluentBuild.FilesAndDirectories
{
    ///<summary />
    public class BuildFolderTests
    {
        ///<summary />
        public void CreateDirecory_ShouldCallWrapper()
        {
            MessageLogger.WindowWidth = 80;
            var expected = "c:\\temp";
            var fs = MockRepository.GenerateStub<IFileSystemWrapper>();
            var folder = new BuildFolder(fs, null, expected);
            folder.Create();
            fs.AssertWasCalled(x=>x.CreateDirectory(expected));
        }

        ///<summary />
        public void DeleteDirecory_ShouldDeleteIfFolderExists()
        {
            MessageLogger.WindowWidth = 80;
            var expected = "c:\\temp";
            var fs = MockRepository.GenerateStub<IFileSystemWrapper>();
            var folder = new BuildFolder(fs, null, expected);
            fs.Stub(x => x.DirectoryExists(expected)).Return(true);
            folder.Delete();
            fs.AssertWasCalled(x => x.DeleteDirectory(expected, true));
        }

        
        ///<summary />
        public void Create_Should_Have_Path()
        {
            var expected = "c:\\temp";
            var folder = new BuildFolder(expected);
            Assert.That(folder.ToString(), Is.EqualTo(expected));
        }

        ///<summary />
        public void Create_Should_Build_SubFolder()
        {
            var folder = new BuildFolder("c:\\temp").SubFolder("tmp");
            Assert.That(folder.ToString(), Is.EqualTo("c:\\temp\\tmp"));
        }

        ///<summary />
        public void Create_Should_Build_Recursive_And_SubFolder()
        {
            var folder = new BuildFolder("c:\\temp").RecurseAllSubFolders().SubFolder("tmp");
            Assert.That(folder.ToString(), Is.EqualTo(@"c:\temp\**\tmp"));
        }

        ///<summary />
        public void Create_Should_Build_File()
        {
            var file = new BuildFolder("c:\\temp").File("test.txt");
            Assert.That(file.ToString(), Is.EqualTo(@"c:\temp\test.txt"));
        }

        ///<summary />
        public void Files_ShouldCreateFileset()
        {
            var mockFilesetFactory = MockRepository.GenerateStub<IFileSetFactory>();
            var mockFileset = MockRepository.GenerateMock<IFileSet>();
            mockFilesetFactory.Stub(x => x.Create()).Return(mockFileset);

            new BuildFolder(null, mockFilesetFactory, "c:\\temp").Files("*.*");

            mockFileset.AssertWasCalled(x=>x.Include("c:\\temp\\*.*"));
            
            
        }
    }
}