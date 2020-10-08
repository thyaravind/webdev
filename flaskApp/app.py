from flask import Flask, render_template,request, flash, redirect, url_for
import os.path
import json
from werkzeug.utils import secure_filename


app = Flask(__name__)
app.secret_key = 'sfasdgafgdfgdggdaf'

@app.route('/')
def home():
    return render_template('home.html')

@app.route('/your-url',methods = ['GET','POST'])
def your_url():
    if request.method == 'POST':
#checking whether the dictfile is created
        if os.path.exists('dictfile.json'):
            with open('dictfile.json') as f:
                dic = json.load(f)
        else:
            dic = {}
            with open('dictfile.json','w') as f:
                json.dump(dic,f)

#checking whether the code already created
        if request.form['code'] in dic.keys():
            flash('code already exists')
            return redirect(url_for('home'))

#adding url or file
        else:
            if 'url' in request.form.keys():
                dic[request.form['code']] = {'url':request.form['url']}

            else:
                f = request.files['files']
                full_name = request.form['code'] + secure_filename(f.filename)
                f.save('/Users/aravind/OneDrive/OneDocuments/DataProjects/flaskApp/static/user_files'+full_name)
                dic[request.form['code']]['file'] = full_name


            with open('dictfile.json','w') as f:
                json.dump(dic,f)

            return redirect(url_for('home'))
'''

if 'url' in dic[request.form['code']].keys:

    return render_template('your.html',code = request.form['code'])
'''
