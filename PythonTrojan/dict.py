import urllib, urllib2, json
from urlparse import urlparse
import easygui as eg


def dict():
    FieldNames = ['TranSrc:', 'TranRes:', 'SmartRes:']
    FieldValues = ['', '', '']
    url = 'http://fanyi.youdao.com/translate?smartresult=dict&smartresult=rule&smartresult=ugc&sessionFrom=https://www.baidu.com/link'
    while True:
        content = str(list(
            eg.multenterbox('Please enter the phrase U want to translate', 'Fake Dict Via Li_Xin', FieldNames,
                            FieldValues))[0].encode('utf-8'))
        data = {}
        data['type'] = 'AUTO'
        data['i'] = ''
    data['doctype'] = 'json'
    data['xmlVersion'] = '1.8'
    data['keufrom'] = 'fanyi.web'
    data['ue'] = 'UTF-8'
    data['action'] = 'FY_BY_CLICKBUTTON'
    data['typeResult'] = 'true'
    data['i'] = content
    data = urllib.urlencode(data).encode('utf-8')
    response = urllib2.urlopen(url, data)
    html = response.read().decode('utf-8')
    target = json.loads(html)
    result = target['translateResult'][0][0]['tgt']
    n = result.encode('utf-8')
    FieldValues[1] = n
    FieldValues[0] = content
    et = ''
    if 'smartResult' in target:
        entries = list(target['smartResult']['entries'])
        for i in range(len(entries)):
            if (not entries[i] == ''):
                et = et + entries[i].encode('utf-8') + '    '
        FieldValues[2] = et
    else:
        FieldValues[2] = ''


if __name__ == '__main__':
    dict()
