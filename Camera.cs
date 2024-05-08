using OpenTK.Mathematics;
public class Camera
{
    public Vector3 Position { get; set; }
    public Vector3 ViewDirection { get; set; }
    public Vector3 UpDirection { get; set; }
    public Vector3 RightDirection { get; set; }
    public int Distance { get; set; }
    public Vector3 PlaneCenter { get; set; }
    public Vector3 TopLeft { get; set; }
    public Vector3 TopRight { get; set; }
    public Vector3 BottomLeft { get; set; }
    public Vector3 BasisU { get; set; }
    public Vector3 BasisV { get; set; }

    public Camera()
    {
        Position = new Vector3(0,0,0);
        Distance = 3;
        ViewDirection = new Vector3(0,0,1);
        UpDirection = new Vector3(0,1,0);
        RightDirection = new Vector3(1,0,0);
        ImagePlane();
    }
    private void ImagePlane()
    {
        PlaneCenter = Position + Distance*ViewDirection;
        TopLeft = PlaneCenter + UpDirection - RightDirection;
        TopRight = PlaneCenter + UpDirection + RightDirection;
        BottomLeft = PlaneCenter - UpDirection - RightDirection;
        BasisU = TopRight - TopLeft;
        BasisV = BottomLeft - TopLeft;

    }
}