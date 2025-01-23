﻿namespace TaskCollaborationSystem.ConsoleApp.Entities.Interface
{
    public interface IEntity
    {
        public string Name { get; set; }
        void InputAndPopulate();
        void Show();
    }
}
