# Maui CarouselView Problems

Shows the problems with MAUI CarouselView on Windows

Just start the application. This will create just 1 item in the ObservableCollection.
If you press the button, the ObervableCollection is cleared and a new item is placed inside the collection.

On Android, the new item is shown as expected.
On Windows, it still shows the old item. Also, if you would go and change the old item, then those changes would show up, so Windows does not do the binding to the new object.


