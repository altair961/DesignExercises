using SharedKernel;

namespace AppointmentScheduling.Core.Model.ScheduleAggregate
{
    public class Teacher : Entity<int>
    {
        public virtual string Name { get; set; }
        public Teacher(int id)
            : base(id)
        {        
        }

        private Teacher()
        {
        }
    }
}
