using System;
using System.Collections.Generic;

// Mendefinisikan state dalam automata
public enum State
{
    Start,
    MembuatLaporan,
    MengeditLaporan,
    Ketemu,
    
}
public enum Trigger { proses, cancel,cari,edit };

// Mendefinisikan transisi dalam automata

// Mensimulasikan alur interaksi dalam aplikasi
class StateTodo
{
    public class Transition
    {
        public State StateAwal;
        public State StateAkhir;
        public Trigger Trigger;

        public Transition(State stateAwal, State stateAkhir, Trigger trigger)
        {
            this.StateAwal = stateAwal;
            this.StateAkhir = stateAkhir;
            this.Trigger = trigger;
        }
    }

    Transition[] transisi =
    {
        new Transition(State.Start, State.MembuatLaporan, Trigger.proses),
        new Transition(State.MembuatLaporan, State.Ketemu, Trigger.cari),

        new Transition(State.MembuatLaporan, State.Start, Trigger.cancel),
        new Transition(State.MembuatLaporan, State.MengeditLaporan, Trigger.edit),

        new Transition(State.MengeditLaporan, State.MembuatLaporan, Trigger.proses),
      //  new Transition(State.Mengajar, PengerjaanState.bersedia, Trigger.selesai)
    };

    public State currentState = State.Start;
    public Dictionary<string, State> tasks = new Dictionary<string, State>(); // Dictionary to store tasks with their states

    public State GetNextState(State stateAwal, Trigger trigger)
    {
        foreach (Transition perubahan in transisi)
        {
            if (stateAwal == perubahan.StateAwal && trigger == perubahan.Trigger)
            {
                return perubahan.StateAkhir;
            }
        }
        return stateAwal; // Return current state if no transition found
    }

    public void ActivateTrigger(Trigger trigger)
    {
        Console.WriteLine("Masukan Prose");
         currentState = GetNextState(currentState, trigger);
        Console.WriteLine("State Anda adalah: " + currentState);
    }
}
