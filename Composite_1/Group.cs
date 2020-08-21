using System.Collections.Generic;


namespace Composite_1
{
    public class Group : IParticipant
    {
        public string Name { get; set; }
        public List<IParticipant> Members { get; private set; }

        public Group()
        {
            Members = new List<IParticipant>();
        }

        public void Send()
        {
            foreach (var member in Members)
            {
                member.Send();
            }
        }
    }
}