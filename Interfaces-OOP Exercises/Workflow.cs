using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Interfaces_OOP_Exercises
{
    public class Workflow
    {
        private readonly List<IActivity> _activities = new List<IActivity>();

        public void AddActivity(IActivity activity)
        {
            _activities.Add(activity);
        }

        public IEnumerable<IActivity> Get()
        {
            return _activities;
        }
    }
}