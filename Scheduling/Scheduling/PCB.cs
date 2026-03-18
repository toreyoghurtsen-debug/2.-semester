using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduling
{
    public class PCB
    {
        public string ProcessName { get; set; }
        public int ProcessPriority { get; set; }

        public ProcessStateType ProcessState { get; set; }
        public enum ProcessStateType { New, Ready, Running, Waiting, Terminated };

        public override string ToString()
        {
            return $"Process Name: {ProcessName}, Priority: {ProcessPriority}, State: {ProcessState}";
        }
    }
}
