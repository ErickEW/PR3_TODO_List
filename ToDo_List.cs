using System;
using System.Collections.Generic;

namespace PR3_ToDo_List
{
    class ToDoList
    {
        
        string page = "";
        List<ThingsToDo> printAll = new List<ThingsToDo>();
        List<ThingsToDo> printPending = new List<ThingsToDo>();
        List<ThingsToDo> printFinished = new List<ThingsToDo>();

        public string PageMessage()
        {
            return this.page;
        }

        public void Add(ThingsToDo pending)
        {
            if(pending.getPending() == false)
            {
                this.printAll.Add(pending);
                this.page = "Your task has been added correctly";
            }
            else
            {
                this.page = "You can´t add a task that has been finished";
            } 
        }

        public void Delete(int pendingNum)
        {
            if(this.printAll.Count >= pendingNum)
            {
                this.printAll.RemoveAt(pendingNum-1);
                this.page = "The task has been deleted successfully ";
            }
            else
            { 
                this.page = "The task that you want to delete doesn´t exist";
            }
        } 
        
        public void PrintList(List<ThingsToDo> list)
        {
            this.page = "";
            
            if(list.Count == 0)
            {
                this.page = "There´s no tasks to complete";
            }
            else
            {
                foreach (var item in list)
                {
                    this.page = this.page + item.getThing() + ":"; 
                    if (item.getPending() == false)
                    {
                        this.page = this.page + " Pending. ";
                    } 
                    else
                    {
                        this.page = this.page + " Finished. ";
                    }
                }
            }
        }
        public void AllList()
        {
            PrintList(this.printAll);
        }

        public void Finished(ThingsToDo ToDo)
        {
            if(this.printAll.Contains(ToDo))
            {
                this.printAll.Remove(ToDo);
                ThingsToDo ToDoFinished = new ThingsToDo(ToDo.getThing(), true);
                this.printAll.Add(ToDoFinished);
            
                this.page = "The task has been marked as completed, good job";
            }
            else
            { 
                this.page = "The task that you want to complete doesn´t exist";
            }
        } 
        
        public void PendingList()
        {
            this.printPending.Clear();

            foreach (var item in this.printAll)
            {
                if(item.getPending() == false)
                {
                    this.printPending.Add(item);
                }
            }

            PrintList(this.printPending);
        }


        public void FinishedList()
        {
            this.printFinished.Clear();

            foreach (var item in this.printAll)
            {
                if(item.getPending() == true)
                {
                    this.printFinished.Add(item);
                }
            }

           PrintList(this.printFinished);
        }
    }
}
        

       
        
       
        
      