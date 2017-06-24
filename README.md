# Xamarin Android WheelPicker Binding Library #

This is a Xamarin.Droid Binding Library for WheelPicker.
Latest Version is available on NuGet: [Xam.WheelPicker](https://www.nuget.org/packages/Xam.WheelPicker/)
Please see original [Xam.WheelPicker project](https://github.com/AigeStudio/WheelPicker) for documentation.
## Usage ##

First use Xam.WheelPicker nuget from NuGet Packet Manager.

##### AXML #####
Import WheelPicker namespace as :
```
xmlns:aigestudio="http://schemas.android.com/apk/res-auto"
```

Define WheelPicker control in your View:
```
<com.aigestudio.wheelpicker.WheelPicker
    android:id ="@+id/myWheelPicker "
    android:layout_width="match_parent"
    android:layout_height="wrap_content"
    aigestudio:wheel_curved="true"
    aigestudio:wheel_item_text_color="#A7A7DB"
    aigestudio:wheel_item_text_size="24sp"
    aigestudio:wheel_selected_item_text_color="#536D8A"/>
```
##### Code #####
Define a WheelPicker Control and initialize it with FindViewById():
```
[Activity]
    public class MyActivity : Activity
    {
        private Com.Aigestudio.Wheelpicker.WheelPicker _myWheelPicker;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MyActivity);
            this._myWheelPicker = FindViewById<Com.Aigestudio.Wheelpicker.WheelPicker>(Resource.Id.myWheelPicker);
            this.InitWheelPicker();
        }
        ...
    }
```

Initiate WheelPicker Control by setting Data Property:
```
...
private void InitWheelPicker()
{
    this._myWheelPicker.Data = new List<object>();
}
```

You can also customize WheelPicker's View:
```
private void InitWheelPicker()
{
    this._myWheelPicker.Data = new List<object>();
    this._myWheelPicker.SetAtmospheric(true);
    this._myWheelPicker.Curved = true;
    this._myWheelPicker.SetCurtain(true);
}
```

For the complete Property and Method List please see [IWheelPicker Interface](https://github.com/AigeStudio/WheelPicker/blob/master/WheelPicker/src/main/java/com/aigestudio/wheelpicker/IWheelPicker.java)


Easy!

Have fun!

##Follow Me

Twitter: @markjackmilian
MyBlog: markjackmilian.net
Linkedin: linkedin
