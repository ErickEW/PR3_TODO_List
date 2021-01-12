using System;

namespace PR3_ToDo_List
{
    class ThingsToDo
    {
        string thing { get; set; }
        bool pending  { get; set; }

        public ThingsToDo (string thing, bool pending)
        {
            this.thing = thing;
            this.pending = pending;
        }

        public string getThing()
        {
            return thing;
        }

        public bool getPending()
        {
            return pending;
        }
    }
}