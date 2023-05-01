from http.server import HTTPServer, BaseHTTPRequestHandler
import json
import json as simplejson


#Defining a HTTP request Handler class
class RequestHandler(BaseHTTPRequestHandler):
	#sets basic headers for the server
	def set_headers(self):
		self.send_response(200)
		self.send_header('Content-type','text/json')
		self.end_headers()
		######

	#reads the contents of the request
	def read_content(self):
		#reads the length of the Headers
		length = int(self.headers['Content-Length'])
		#reads the contents of the request
		content = self.rfile.read(length)
		return json.loads(content)
		######
	
	#GET Method Defination
	def do_GET(self):
		#defining all the headers
		self.set_headers()
		self.wfile.write(json.dumps({"result": "ok"}).encode())
		######

	#POST method defination
	def do_POST(self):
		self.set_headers()
		data = self.read_content()
		
		#add your logic here

		####################
		
		self.wfile.write(json.dumps(data).encode())
		######


if __name__ == '__main__':
	# Server Initialization
	server = HTTPServer(('127.0.0.1', 8080), RequestHandler)
	server.serve_forever()