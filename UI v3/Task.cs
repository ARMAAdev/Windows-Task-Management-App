using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace taskManager
{
    public class Group
    {
        private string name;
        private Color color;

        public string Name { get { return name; } set { name = value; } }
        public Color Color { get { return color; } set { color = value; } }

        public Group(string _name, Color _color)
        {
            name = _name;
            color = _color;
        }
    }

    public class Task
    {
        private string title;
        private string description;
        private DateTime date;
        private DateTime time;
        private Group group;
        private addTask form;

        public string Title { get { return title; } set { title = value; } }
        public string Description { get { return description; } set { description = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
        public DateTime Time { get { return time; } set { time = value; } }
        public Group Group { get { return group; } set { group = value; } }
        public addTask Form { get { return form; } set { form = value; } }

        public Task()
        {

        }

        public Task(string _title, string _description, DateTime _date, DateTime _time, addTask _form)
        {
            this.Title = _title;
            this.Description = _description;
            this.Date = _date;
            this.Time = _time;
            this.Form = _form;
        }
    }
}
