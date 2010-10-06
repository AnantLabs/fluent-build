﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;


namespace FluentBuild.Compilation
{
    ///<summary />
    public class TargetTests
    {
        private BuildTask _buildTask;
        private Target _target;

        ///<summary />
        public void Setup()
        {
            _buildTask = new BuildTask(null);
            _target = new Target(_buildTask);
        }

        ///<summary />
        public void CreateExe()
        {
            BuildTask buildTask = _target.Executable;
            Assert.That(buildTask, Is.Not.Null);
            Assert.That(buildTask.TargetType, Is.EqualTo("exe"));
        }

        ///<summary />
        public void CreateLibrary()
        {
            BuildTask buildTask = _target.Library;
            Assert.That(buildTask, Is.Not.Null);
            Assert.That(buildTask.TargetType, Is.EqualTo("library"));
        }

        ///<summary />
        public void CreateModule()
        {
            BuildTask buildTask = _target.Module;
            Assert.That(buildTask, Is.Not.Null);
            Assert.That(buildTask.TargetType, Is.EqualTo("module"));
        }

        ///<summary />
        public void CreateWindowsExe()
        {
            BuildTask buildTask = _target.WindowsExecutable;
            Assert.That(buildTask, Is.Not.Null);
            Assert.That(buildTask.TargetType, Is.EqualTo("winexe"));
        }
    }
}