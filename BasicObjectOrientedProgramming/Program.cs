using BasicObjectOrientedProgramming;

var appointment = new MedicalAppointment("John Doe", new DateTime(2026, 10, 1));

appointment.OverwriteMonthAndDay(5, 1);
appointment.MoveByMonthAndDays(1, 2);

appointment.Reschedule(new DateTime(2026, 10, 10));