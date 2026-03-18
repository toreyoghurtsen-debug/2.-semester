using Microsoft.VisualStudio.TestTools.UnitTesting; 
using Scheduling; 

namespace TeamA5UnitTest
{
    [TestClass]
    public class PCBTests // Der benyttes AAA
    {
        [TestMethod]
        public void ToString_WhenPropertiesAreSet_ReturnsCorrectString()
        {
            // Arrange
            var pcb = new PCB
            {
                ProcessName = "Explorer.exe",
                ProcessPriority = 5,
                ProcessState = PCB.ProcessStateType.Ready
            };
            string expected = "Process Name: Explorer.exe, Priority: 5, State: Ready";

            // Act
            string actual = pcb.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProcessState_WhenChanged_Updates()
        {
            // Arrange
            var pcb = new PCB { ProcessState = PCB.ProcessStateType.New };
            var targetState = PCB.ProcessStateType.Running;

            // Act 
            pcb.ProcessState = targetState;

            // Assert 
            Assert.AreEqual(PCB.ProcessStateType.Running, pcb.ProcessState);
        }
    }
}
