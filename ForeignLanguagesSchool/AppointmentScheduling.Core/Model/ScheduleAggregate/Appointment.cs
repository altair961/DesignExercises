using SharedKernel;
using System;

namespace AppointmentScheduling.Core.Model.ScheduleAggregate
{
    public class Appointment : Entity<Guid>
    {
        public Guid GuidScheduleIe { get; private set; }
        public int AppointmentTypeId { get; private set; }
        public int ClientId { get; private set; }
        public Guid ScheduleId { get; private set; }
        public int StudentId { get; private set; }
        public int RoomId { get; private set; }
        public int? TeacherId { get; private set; }
        public int AppointmentId { get; private set; }
        public DateTimeRange TimeRange { get; private set; }
        public string Title { get; private set; }

        public Appointment(Guid id)
            : base(id)
        {
        }

        private Appointment()
            : base(Guid.NewGuid()) // Required for EF
        {
        }

        public void UpdateRoom(int newRoomId)
        {
            RoomId = newRoomId;
            //Raise AppointmentUpdated Event
        }

        public void UpdateTime(DateTimeRange newStartEnd)
        {
            TimeRange = newStartEnd;
            //Raise AppointmentUpdated Event
        }

        // Factory method for creation
        public static Appointment Create(Guid scheduleId,
            int clientId, int studentId,
            int roomId, DateTime startTime, DateTime endTime,
            int appointmentTypeId, int? teacherId, string title)
        {
            Guard.ForLessEqualZero(clientId, "clientId");
            Guard.ForLessEqualZero(studentId, "studentId");
            Guard.ForLessEqualZero(roomId, "roomId");
            Guard.ForLessEqualZero(appointmentTypeId, "appointmentTypeId");
            Guard.ForNullOrEmpty(title, "title");

            var appointment = new Appointment(Guid.NewGuid());
            appointment.ScheduleId = scheduleId;
            appointment.StudentId = studentId;
            appointment.ClientId = clientId;
            appointment.RoomId = roomId;
            appointment.TimeRange = new DateTimeRange(startTime, endTime);
            appointment.AppointmentTypeId = appointmentTypeId;
            appointment.TeacherId = teacherId;
            appointment.Title = title;
            return appointment;
        }

        public void Schedule()
        {
            // Verify the appointment fits in Schedule
            // Store the appointment
            // Raise AppointmentScheduled Event
        }
    }
}
