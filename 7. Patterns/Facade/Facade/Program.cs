﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            TextEditor txt = new TextEditor();
            Compiller comp = new Compiller();
            CLR clr = new CLR();

            VisualStudioFacade ide = new VisualStudioFacade(txt, comp, clr);
            Programmer programmer = new Programmer();
            programmer.CreateApplication(ide);

            Console.ReadLine();
        }
    }

    class TextEditor
    {
        public void CreateCode()
        {
            Console.WriteLine("Написание код");
        }
        public void Save()
        {
            Console.WriteLine("Сохранение кода");
        }
    }

    class Compiller
    {
        public void Compile()
        {
            Console.WriteLine("Компиляция приложения");
        }
    }
    class CLR
    {
        public void Execute()
        {
            Console.WriteLine("Выполнение приложения");
        }
        public void Finish()
        {
            Console.WriteLine("Завершение работы приложения");
        }
    }

    class VisualStudioFacade
    {
        TextEditor textEditor;
        Compiller compiller;
        CLR clr;

        public VisualStudioFacade(TextEditor te, Compiller compil, CLR c)
        {
            textEditor = te;
            compiller = compil;
            clr = c;
        }

        public void Start()
        {
            textEditor.CreateCode();
            textEditor.Save();
            compiller.Compile();
            clr.Execute();
        }
        public void Stop()
        {
            clr.Finish();
        }
    }
    class Programmer
    {
        public void CreateApplication(VisualStudioFacade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}
