﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLib
{
    public class Schedule
    {
        public DateTime startTime;
        public DateTime endTime;

        public List<DayOfWeek> daysOfWeek = new List<DayOfWeek>();
    }

    public class Courses
    {
        public SortedList<string, Course> sortedList = new SortedList<string, Course>();
        public string courseCode;
        // indexer property allows array access to sortedList via the class object
        // and catching missing keys and duplicate key exceptions 
        // notice the indexer property definition shows how it will be used in the calling code:
        // if we have:
        //     People people;
        // then we can call:
        //     people[email] to access the Person object with that email address
        // and value will be the Person object (person) being added to the list in the case of:
        //     people[email] = person;
        public Course this[string courseCode]
        {
            get
            {
                Course returnVal;
                try
                {
                    returnVal = (Course)sortedList[courseCode];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                try
                {
                    // we can add to the list using these 2 methods
                    //      sortedList.Add(email, value);
                    sortedList[courseCode] = value;
                }
                catch
                {
                    // an exception will be raised if an entry with a duplicate key is added
                    // duplicate key handling (currently ignoring any exceptions)
                }
            }
        }
        public Courses()
        {
            Course thisCourse;
            Schedule thisSchedule;

            Random rand = new Random();

            // generate courses IGME-200 through IGME-299
            for (int i = 200; i < 300; ++i)
            {
                // use constructor to create new course object with code and description
                thisCourse = new Course(($"IGME-{i}"), ($"Description for IGME-{i}"));

                // create a new Schedule object
                thisSchedule = new Schedule();
                for (int dow = 0; dow < 7; ++dow)
                {
                    // 50% chance of the class being on this day of week
                    if (rand.Next(0, 2) == 1)
                    {
                        // add to the daysOfWeek list
                        thisSchedule.daysOfWeek.Add((DayOfWeek)dow);

                        // select random hour of day
                        int nHour = rand.Next(0, 24);

                        // set start and end times of minute duration
                        // select fixed date to allow time calculations
                        thisSchedule.startTime = new DateTime(1, 1, 1, nHour, 0, 0);
                        thisSchedule.endTime = new DateTime(1, 1, 1, nHour, 50, 0);
                    }
                }

                // set the schedule for this course
                thisCourse.schedule = thisSchedule;

                // add this course to the SortedList
                this[thisCourse.courseCode] = thisCourse;
            }
        }


        public void Remove(string courseCode)
        {
            if (courseCode != null)
            {
                sortedList.Remove(courseCode);
            }
        }
    }

    public class Course
    {
        public string courseCode;
        public string description;
        public string teacherEmail;
        public Schedule schedule;

        public Course()
        {

        }

        public Course(string courseCode, string description)
        {
            this.courseCode = courseCode;
            this.description = description;
        }

    }
}
