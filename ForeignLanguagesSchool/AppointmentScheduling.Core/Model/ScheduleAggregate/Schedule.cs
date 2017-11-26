using SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppointmentScheduling.Core.Model.ScheduleAggregate
{
    public class Schedule : Entity<Guid>
    {
        public int SchoolId { get; private set; }

        //not persisted
        public DateTimeRange DateRange { get; private set; }

        private List<Appointment> appointments;
        public IEnumerable<Appointment> Appointments
        {
            get
            {
                return appointments.AsEnumerable(); 
            }
            set
            {
                appointments = (List<Appointment>)value;
            }
        }

        public Schedule(Guid id, DateTimeRange dateRange)
            : base(id)
        {
            // DateRange = 
        }
    }
}
