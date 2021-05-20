#include "pch.h"
#include "AssesTwo.h";
#include <cmath>;

double* cppSinCos(double rad) {
	double* sinCos = new double[2];
	sinCos[0] = std::sin(rad);
	sinCos[1] = std::cos(rad);
	return sinCos;
}

int releaseMemory(double* array) {
	delete[] array;
	return 0;
}
