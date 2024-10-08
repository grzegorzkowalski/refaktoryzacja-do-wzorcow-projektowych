﻿namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions
{
	public interface IEmployee
    {
        void Work();
        void AttendMeeting();
    }

    // Klasa Employee implementuje IEmployee i dodaje wspólne właściwości
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public void Work() { /* Implementacja */ }
        public void AttendMeeting() { /* Implementacja */ }
    }

    // Klasa Manager dziedziczy po Employee, ponieważ jest specjalnym typem pracownika
    public class Manager : Employee
    {
        public void ManageTeam() { /* Implementacja */ }
    }
}
