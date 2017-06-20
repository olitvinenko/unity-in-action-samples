package com.companyname.testplugin;

/* an approach that creates an Activity to list in the android.manifest
import android.app.Activity;
import android.os.Bundle;
import android.util.Log;

public class TestPlugin extends Activity {
	protected static TestPlugin _instance;
	
	public static void startActivity(Activity unityActivity) {
		Intent intent = new Intent(unityActivity, TestPlugin.class);
		unityActivity.startActivity(intent);
	}
	
	protected void onCreate(Bundle savedInstanceState) {
		Log.d("TestPlugin", "onCreate called");		// print debug message to logcat
		super.onCreate(savedInstanceState);
		
		_instance = this;
	}
}
*/
/* or even a Fragment instead of an Activity
import android.app.Fragment;
import android.app.FragmentManager;
import android.app.FragmentTransaction;
import android.os.Bundle;
import android.util.Log;

public class TestPlugin extends Fragment {
	protected static TestPlugin _instance;
	
	public static void startActivity(Activity unityActivity) {
		FragmentManager fragmentManager = unityActivity.getFragmentManager();
		FragmentTransaction fragmentTransaction = fragmentManager.beginTransaction();
		
		_instance = new TestPlugin();
		fragmentTransaction.add(_instance, "Test Plugin");
		fragmentTransaction.commit();
	}
	
	protected void onCreate(Bundle savedInstanceState) {
		Log.d("TestPlugin", "onCreate called");		// print debug message to logcat
		super.onCreate(savedInstanceState);
		
		_instance = this;
	}
}
*/

public class TestPlugin {
	private static int number = 0;
	
	public static int getNumber() {
		number++;
		return number;
	}
	
	public static String getString(String message) {
		return message.toLowerCase();
	}
}