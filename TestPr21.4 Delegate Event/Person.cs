using System;
using System.Collections.Generic;
using System.Text;

namespace TestPr21._4_Delegate_Event
{
    class Person
    {
        public event Action GoToSleep;

        public event EventHandler NotSleepNow;  // объявляем дополнительное событие
        public string NamePerson { get; set; }

        public void TakeTime(DateTime now)
        {
            if (now.Hour <= 8)
            {
                GoToSleep?.Invoke();
            }
            else
            {
                var args = new EventArgs(); // создаем дополнительный параметр и потом передаем его в дополнительное событие NotSleepNow
                NotSleepNow?.Invoke(this, args);  // передаем тот объект который был вызван
            }
        }
    }
}