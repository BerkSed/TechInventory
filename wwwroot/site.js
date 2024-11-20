function showNotification(title, options) {
    if (Notification.permission === 'granted') {
        navigator.serviceWorker.getRegistration().then(registration => {
            registration.showNotification(title, options);
        });
    } else {
        console.warn('Notificaciones no habilitadas');
    }
}
