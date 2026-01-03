if (!init)
{
    init = true;
    start_angle = ((direction + 180) % 360) + 15;
}
if (middespawn)
{
    if (traveldistance >= maxdistance)
    {
        instance_destroy();
    }
}
if (spindir != 0)
{
    var _dist = point_distance(x, y, obj_growtangle.x, obj_growtangle.y);
    var __theta = start_angle + ((_dist / 103) * spindir * 22.5) + ((-spindir * timer) / 3);
    x = obj_growtangle.x + lengthdir_x(_dist, __theta);
    y = obj_growtangle.y + lengthdir_y(_dist, __theta);
    direction = point_direction(x, y, obj_growtangle.x, obj_growtangle.y);
}
else if (wall_destroy == 1)
{
    if (x < (__view_get(e__VW.XView, 0) - 80))
    {
        instance_destroy();
    }
    if (x > (__view_get(e__VW.XView, 0) + 760))
    {
        instance_destroy();
    }
    if (y < (__view_get(e__VW.YView, 0) - 80))
    {
        instance_destroy();
    }
    if (y > (__view_get(e__VW.YView, 0) + 580))
    {
        instance_destroy();
    }
}
if (updateimageangle == 1)
{
    image_angle = direction;
}

enum e__VW
{
    XView,
    YView,
    WView,
    HView,
    Angle,
    HBorder,
    VBorder,
    HSpeed,
    VSpeed,
    Object,
    Visible,
    XPort,
    YPort,
    WPort,
    HPort,
    Camera,
    SurfaceID
}
以上是其中一个字符串的内容，用C#代码实现替换e__VW.XView为e__VW__XView=0；e__VW.YView为e__VW__XView=1等等，并放在代码开头，删去enum{...}。