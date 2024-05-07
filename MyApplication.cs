namespace Template
{
    class MyApplication
    {
        // member variables
        public Surface screen;
        // constructor
        public MyApplication(Surface screen)
        {
            this.screen = screen;
        }
        // initialize
        public void Init()
        {

        }
        // tick: renders one frame
        public void Tick()
        {
            screen.Clear(0);
            screen.Print("hello world", 2, 2, 0xffffff);
            //screen.Box(x1:0, y1:200, x2:700, y2:280, c:0x0000ff);
            //Box(int x1, int y1, int x2, int y2, int c)
            //screen.Line(x1:500, y1:0, x2:580, y2:700, c:0x0000ff);
           
            for (int ypix = 100; ypix < 180; ypix++)
            {
                int color = (255 / 40) * (ypix - 100);
                screen.Line(0,ypix,screen.width, ypix, color*256*257);
            }
            
            screen.Line( 220, 150, 420, 150, 0xffffff );
            screen.Line( 220, 150, 220, 250, 0xffffff );
            screen.Line( 420, 150, 420, 250, 0xffffff );
            screen.Line( 220, 250, 420, 250, 0xffffff );

            screen.Line(2, 20, 160, 20, 0xff0000);
            
        }
    }
}