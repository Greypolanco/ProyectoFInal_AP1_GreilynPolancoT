public static class Notificaciones
{
    public static void ShowNotification(this NotificationService notificationService, string title, string message, NotificationSeverity severity)
    {
        notificationService.Notify(new NotificationMessage 
        { 
            Summary = title,
            Detail = message, 
            Severity = severity });
    }
    public static void Info(this NotificationService notificationService, string title, string message)
    {
        notificationService.Notify(
            new NotificationMessage{
                Summary = title,
                Detail = message,
                Severity = NotificationSeverity.Info
            }
        );
    }
    public static void Error(this NotificationService notificationService, string? message)
    {
        notificationService.Notify(
            new NotificationMessage{
                Summary = "Algo ha ido mal...",
                Detail = message,
                Severity = NotificationSeverity.Error
            }
        );
    }
}