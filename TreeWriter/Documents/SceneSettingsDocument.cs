﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeWriterWF
{
    public class SceneSettingsDocument : EditableDocument
    {
        public SceneData Data;
        public ManuscriptDocument ParentDocument;

        public override void Load(Model Model, Main View, string Path)
        {
            this.Path = Path;
            var split = Path.Split('&');
            if (split.Length != 2) throw new InvalidOperationException();

            var openManuscript = new Commands.OpenPath(split[0], Commands.OpenCommand.OpenStyles.CreateView);
            openManuscript.Execute(Model, View);
            if (!openManuscript.Succeeded) throw new InvalidOperationException();
            ParentDocument = openManuscript.Document as ManuscriptDocument;
            if (ParentDocument == null) throw new InvalidOperationException();
            var sceneName = System.IO.Path.GetFileNameWithoutExtension(split[1]);
            Data = ParentDocument.Data.Scenes.FirstOrDefault(s => s.Name == sceneName);
            ParentDocument.OpenScenes.Add(this);
        }

        public override void Close()
        {
            ParentDocument.OpenScenes.Remove(this);
        }

        protected override string ImplementGetEditorTitle()
        {
            return System.IO.Path.GetFileNameWithoutExtension(ParentDocument.Path) + " - $ " + Data.Name;
        }

        public override string GetContents()
        {
            return Data.Prose;
        }

        public override int CountWords(Model Model, Main View)
        {
            return WordParser.CountWords(Data.Prose);
        }

        public override DockablePanel OpenView(Model Model)
        {
            var r = new DocumentSettingsEditor(this, Data);
            OpenEditors.Add(r);
            return r;
        }

        public override void Save(bool Backup)
        {
            ParentDocument.Save(Backup);
            NeedChangesSaved = false;
            UpdateViewTitles();
        }

        public override void MadeChanges()
        {
            ParentDocument.MadeChanges();
            base.MadeChanges();
        }
    }
}