# Maui CarouselView Problems

Shows the problems with MAUI CarouselView on Android

If you have an entry in your carousel view and you set the HorizontalTextAlignment to any thing else than "Start" you cannot edit this field because every time you selected it the carousel view jumps to element 1


To reproduce on Android:
- Go to element 3 (Bird)
- try to edit the color value by clicking the field (Start works, the other 2 don't work) -> You are on element 1

Note: On the emulator, you see a strange behavour (by scrolling back and forth if you are on element 2)