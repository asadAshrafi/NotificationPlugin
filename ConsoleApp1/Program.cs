using NotificationPlugin;

EmailNotification emailNotification = new EmailNotification("",503,"","","","");
SmsNotificationDecorator smsNotificationDecorator= new SmsNotificationDecorator(emailNotification,"0954757");
SlackNotification slackNotification = new SlackNotification(smsNotificationDecorator,"pappichulo");
slackNotification.Send("sdfzssfsefa");