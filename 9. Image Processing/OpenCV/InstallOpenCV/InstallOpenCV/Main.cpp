#include "opencv2/imgproc/imgproc.hpp"
#include "opencv2/imgcodecs.hpp"
#include "opencv2/highgui/highgui.hpp"
#include <stdlib.h>
#include <stdio.h>

using namespace cv;

Mat src;
/**
* @function main
*/
int main(int, char** argv)
{
	/// Load an image
	src = imread(argv[1]);

	if (src.empty())
	{
		return -1;
	}


	return 0;
}

